using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_CRUD_Demo.ViewModels
{
    public class UnitEditViewModel : UnitAddViewModel
    {
        public int Id { get; set; }
        public string ExistingPhotoPath { get; set; }


    }
}
