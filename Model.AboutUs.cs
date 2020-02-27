using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

// add library for table attribute.
using System.ComponentModel.DataAnnotations.Schema;

// step 1. RC on the Models folder, add class, create AboutUs class.

namespace MVC5EF6Tables.Models
{
    // initializes a new instance of the table attribute to which it is mapped.
    [Table("tblAboutUs")]
    public class AboutUs
    {
        //get name, set values.
        public int Id { get; set; }
        public string Title { get; set; }
        // The About Us church website page can have multiple images with text, so I need a list of AboutUs, and store in AboutUss. Get details, set values.
        public string Info { get; set; }
        public string Photo { get; set; }
        public string AlternateText { get; set; }

    }
}

// build this project now to get this class compiled.

// Step 2. next retrieve DbSet of AboutUs aswell in the ContextClass.
