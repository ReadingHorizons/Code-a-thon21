using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Code_a_thon21.ViewModels
{
    public class AssignmentDateViewModel
    {
        public string AssignmentName { get; set; }
        public DateTime AssignmentDate { get; set; }
        public bool IsSubmitted { get; set; }
    }
}