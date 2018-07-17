using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProject.Models
{
    public class PhotoModel
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        //PhotoFile. This is a picture file
        [DisplayName("Picture")]
        [MaxLength]
        public byte[] PhotoFile { get; set; }
        public int TotalRate { get; set; }

        //ImageMimeType, stores the MIME type for the PhotoFile
        [HiddenInput(DisplayValue = false)]
        public string ImageMimeType { get; set; }

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        //CreatedDate
        [DataType(DataType.DateTime)]
        [DisplayName("Created Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yy}", ApplyFormatInEditMode = true)]
        public DateTime CreatedDate { get; set; }

        public int UserId { get; set; }
        

    }
}
