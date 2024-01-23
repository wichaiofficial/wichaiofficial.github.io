using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using WX.DVDCentral.BL;
using WX.DVDCentral.BL.Models;
using WX.DVDCentral.UI.Models;

namespace WX.DVDCentral.UI.Controllers
{
    public class RatingController : Controller
    {
        // GET: RatingController
        public ActionResult Index()
        {
            ViewBag.Title = "Movie Ratings";
            return View(RatingManager.Load());
        }

        // GET: RatingController/Details/5
        public ActionResult Details(int id)
        {
            ViewBag.Title = "Movie Rating";
            return View(RatingManager.LoadbyId(id));
        }

        // GET: RatingController/Create
        public ActionResult Create()
        {
            if (Authenticate.IsAuthenticated(HttpContext))
            {
                ViewBag.Title = "Add New Rating";
                return View();
            }
            else
            {
                return RedirectToAction("Login", "User", new { returnUri = UriHelper.GetDisplayUrl(HttpContext.Request) });
            }
        }

        // POST: RatingController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Rating rating)
        {
            try
            {
                RatingManager.Insert(rating);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                ViewBag.Title = "Create New Rating";
                return View();
            }
        }

        // GET: RatingController/Edit/5
        public ActionResult Edit(int id)
        {
            if (Authenticate.IsAuthenticated(HttpContext))
            {
                ViewBag.Title = "Edit Rating Info.";
                return View(RatingManager.LoadbyId(id));
            }
            else
            {
                return RedirectToAction("Login", "User", new { returnUri = UriHelper.GetDisplayUrl(HttpContext.Request) });
            }
        }

        // POST: RatingController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Rating rating)
        {
            try
            {
                RatingManager.Update(rating);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                ViewBag.Title = "Create New Rating";
                return View();
            }
        }

        // GET: RatingController/Delete/5
        public ActionResult Delete(int id)
        {
            ViewBag.Title = "Delete Movie Rating";
            return View(RatingManager.LoadbyId(id));
        }

        // POST: RatingController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Rating rating)
        {
            try
            {
                RatingManager.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                ViewBag.Title = "Delete Rating";
                return View();
            }
        }

		private static HttpClient InitializeClient()
		{
			HttpClient client = new HttpClient();
			client.BaseAddress = new Uri("https://localhost:7281/api/");
			return client;
		}

		public ActionResult Get()
		{
			ViewBag.Title = "Ratings";
			HttpClient client = InitializeClient();

			HttpResponseMessage response = client.GetAsync("Rating").Result;
			string result = response.Content.ReadAsStringAsync().Result;
			dynamic items = (JArray)JsonConvert.DeserializeObject(result);
			List<BL.Models.Rating> ratings = items.ToObject<List<BL.Models.Rating>>();

			return View(nameof(Index), ratings);

		}

		public ActionResult GetOne(int id)
		{
			ViewBag.Title = "Ratings";
			HttpClient client = InitializeClient();
			HttpResponseMessage response = client.GetAsync("Rating/" + id).Result;

			string result = response.Content.ReadAsStringAsync().Result;
			dynamic item = JsonConvert.DeserializeObject(result);
			BL.Models.Rating program = item.ToObject<BL.Models.Rating>();
			return View(nameof(Details), program);
		}

		public ActionResult Insert()
		{
			ViewBag.Title = "Ratings";
			return View(nameof(Create));
		}


		[HttpPost]
		public ActionResult Insert(Rating rating)
		{
			try
			{
				ViewBag.Title = "Ratings";
				HttpClient client = InitializeClient();

				string serializedObject = JsonConvert.SerializeObject(rating);
				var content = new StringContent(serializedObject);
				content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
				HttpResponseMessage response = client.PostAsync("Rating", content).Result;
				return RedirectToAction("Get");

			}
			catch (Exception ex)
			{
				ViewBag.Error = ex.Message;
				return View(nameof(Create), rating);
			}
		}


		public ActionResult Update(int id)
		{
			ViewBag.Title = "Ratings";
			HttpClient client = InitializeClient();

			HttpResponseMessage response = client.GetAsync("Rating/" + id).Result;
			string result = response.Content.ReadAsStringAsync().Result;
			dynamic item = JsonConvert.DeserializeObject(result);
			BL.Models.Rating rating = item.ToObject<BL.Models.Rating>();

			return View(nameof(Edit), rating);
		}

		[HttpPost]
		public ActionResult Update(int id, Rating rating)
		{
			try
			{
				HttpClient client = InitializeClient();

				string serializedObject = JsonConvert.SerializeObject(rating);
				var content = new StringContent(serializedObject);
				content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
				HttpResponseMessage response = client.PutAsync("Rating/" + id, content).Result;
				return RedirectToAction("Get");

			}
			catch (Exception ex)
			{
				ViewBag.Error = ex.Message;
				return View(nameof(Edit), rating);
			}
		}

		public ActionResult Remove(int id)
		{
			ViewBag.Title = "Ratings";
			HttpClient client = InitializeClient();
			HttpResponseMessage response = client.GetAsync("Rating/" + id).Result;
			string result = response.Content.ReadAsStringAsync().Result;
			dynamic item = JsonConvert.DeserializeObject(result);
			BL.Models.Rating rating = item.ToObject<BL.Models.Rating>();
			return View(nameof(Delete), rating);
		}

		[HttpPost]
		public ActionResult Remove(int id, BL.Models.Rating rating)
		{
			try
			{
				HttpClient client = InitializeClient();
				HttpResponseMessage response = client.DeleteAsync("Rating/" + id).Result;
				return RedirectToAction("Get");

			}
			catch (Exception ex)
			{
				ViewBag.Error = ex.Message;
				return View(nameof(Delete), rating);
			}
		}
	}
}
