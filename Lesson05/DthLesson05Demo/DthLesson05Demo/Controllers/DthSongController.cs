using DthLesson05Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace DthLesson05Demo.Controllers
{
    public class DthSongController : Controller
    {
        private static List<DthSong> DthSongs = new List<DthSong>()
        {
            new DthSong{Id=221090028, DthTitle="Đàm Thúy Hường", DthAuthor="K22CNT4", DthArtist="NTU",DthYearlekease=2020},
            new DthSong{Id=1, DthTitle="Đàm Thúy Hường", DthAuthor="K22CNT4", DthArtist="NTU",DthYearlekease=2020}
        };
        // GET: DthSong
        /// <summary>
        /// Hiển thị danh sách bài hát
        /// Author: Đàm Thúy Hường 
        /// </summary>
        /// <returns></returns>
        public ActionResult DthIndex()
        {
            return View(DthSongs);
        }
        //GET: DthCreate
        /// <summary>
        /// Form Thêm mới bài hát
        /// Author: Đàm Thúy Hường
        /// </summary>
        /// <returns></returns>
        public ActionResult DthCreate()
        {
            var dthsong = new DthSong();
            return View(dthsong);
        }
    }
}