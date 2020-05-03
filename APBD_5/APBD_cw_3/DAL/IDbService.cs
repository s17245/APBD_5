using APBD_cw_3.Models;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace APBD_cw_3.DAL
{
    public interface IDbService
    {
        public IEnumerable <Student> GetStudents();
        public IEnumerable <Enrollment> GetEnrollment(string id);
     }
}
