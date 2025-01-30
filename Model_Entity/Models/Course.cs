using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_Entity.Models
{
    public class Course:Entity_ID
    {
        // اسم الدورة
        public string Name { get; set; }

        // وصف الدورة
        public string Description { get; set; }

        //// مدرب الدورة
        //public string Instructor { get; set; }

        //// مدة الدورة (بالساعات أو الأيام)
        //public int Duration { get; set; }

        //// تاريخ بداية الدورة
        //public DateTime StartDate { get; set; }

        //// تاريخ نهاية الدورة
        //public DateTime EndDate { get; set; }

        //// سعر الدورة
        //public decimal Price { get; set; }

        //// حالة الدورة (مثلاً: "مفتوحة"، "مغلقة"، "قيد التقدم")
        //public string Status { get; set; }

        //// عدد الطلاب المسجلين في الدورة
        //public int EnrolledStudents { get; set; }

        //// تصنيف الدورة (مثلاً: "برمجة"، "تصميم"، "إدارة")
        //public string Category { get; set; }

        //// مستوى الدورة (مبتدئ، متوسط، متقدم)
        //public string Level { get; set; }

        //// رابط صورة الدورة
        //public string ImageUrl { get; set; }

        //// تقييم الدورة (من 1 إلى 5)
        //public double Rating { get; set; }

        //// هل الدورة متاحة عبر الإنترنت؟
        //public bool IsOnline { get; set; }

        //// رابط الدورة (إذا كانت متاحة عبر الإنترنت)
        //public string CourseUrl { get; set; }

        public List<User> users { get; set; } = new List<User>();
    }
}
