using System; using System.Collections.Generic; using System.ComponentModel; using System.ComponentModel.DataAnnotations; using System.Linq; using System.Threading.Tasks; using Microsoft.AspNetCore.Builder; using Microsoft.AspNetCore.Http;  namespace portfolio.Model {
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class MyContact      {

        // ADD A UNIQUE IDENTIFIER
        [Key]         public int? ID { get; set; }          [DisplayName("Name")]         [Display(Prompt = "Your name")]         [Required(ErrorMessage = "Required")]         [StringLength(70, MinimumLength = 3, ErrorMessage = "You must enter between 3 to 70 characters")]         public string Name { get; set; }          [DisplayName("Email")]         [Display(Prompt = "Your email address")]         [Required(ErrorMessage = "Required")]         public string Email { get; set; }          [DisplayName("Subject")]         [Display(Prompt = "What are you contacting us about?")]         [Required(ErrorMessage = "Required")]         public string Subject { get; set; }          [DisplayName("Message")]         [Display(Prompt = "Write your message here.")]         [Required(ErrorMessage = "Required")]         [StringLength(150, MinimumLength = 3, ErrorMessage = "Enter between 3 and 150 characters.")]         public string Message { get; set; }


        [DisplayName("I agree")]         public string agree { get; set; }          public string createDate { get; set; }         public string createIP { get; set; }          public string sendDate { get; set; }         public string sendIP { get; set; }          public string reCaptcha { get; set; }

    } } 
