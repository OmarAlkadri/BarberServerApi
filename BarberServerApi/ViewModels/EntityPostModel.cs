using BarberServerApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarberServerApi.ViewModels
{
    public class EntityPostModel
    {
        public int EntityPostId { get; set; }
        public string EntityPostText { get; set; }
        public string EntityPostTime { get; set; }
        public string entityImgVideoUrl { get; set; }
        public BarberModel barber { get; set; }
        public List<CommentModel> CommentModels { get; set; }
        public int likes { get; set; }
    }
}
