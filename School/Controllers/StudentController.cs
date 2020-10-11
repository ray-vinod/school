using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using School.Data;
using School.Models;
using School.Models.ViewModels;

namespace School.Controllers
{
    public class StudentController : Controller
    {
        private readonly skulDbContext _skulDbContext;
        public StudentController(skulDbContext skulDbContext)
        {
            this._skulDbContext = skulDbContext;
        }
        public IActionResult Index()
        {
            List<StudentViewModel> model = new List<StudentViewModel>();
            model = _skulDbContext.Students.Select(s => new StudentViewModel()
            {
                Id = s.Id,
                RollNo = s.RollNo,
                FName = s.FName.ToUpper(),
                MName = s.MName.ToUpper(),
                LName = s.LName.ToUpper(),
                Grade = s.Grade.GradeName

            }).ToList();


            return View(model);
        }
        public IActionResult Create()
        {
            CreateStudentViewModel model = new CreateStudentViewModel();
            //model.GradeList = _skulDbContext.Grades
            //                                .Select(g => new SelectListItem
            //                                {
            //                                    Value = g.GradeId.ToString(),
            //                                    Text = g.GradeName
            //                                }).ToList();

            ViewBag.GradeList = new SelectList(_skulDbContext.Grades, "GradeId", "GradeName");
            ViewBag.SectionList = new SelectList(_skulDbContext.Sections, "SectionId", "SectionName");

            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CreateStudentViewModel model)
        {
            Student student = new Student();
            Address address = new Address();
            Contact contact = new Contact();
            int loclalId = _skulDbContext.Students.Select(s => s.Id).Last();
            int id = _skulDbContext.Students.Last().Id;

            if (ModelState.IsValid)
            {
                try
                {
                    Student std = new Student()
                    {
                        RollNo = model.RollNo,
                        FName = model.FName.ToUpper(),
                        MName = model.MName.ToUpper(),
                        LName = model.LName.ToUpper(),
                        DOB = model.DOB,
                        GradeId = model.GradeId,
                        SectionId = model.SectionId
                    };

                    //ViewBag.RegistrationNo = model.RegistrationNo;
                    //Redirect("~/Views/Address/Create.cshtml");

                    address = new Address()
                    {
                        Id = loclalId + 1,
                        Permanent = model.Address.Permanent,
                        Temporary = model.Address.Temporary
                    };

                    contact = new Contact()
                    {
                        Id = loclalId + 1,
                        Residence = model.Contact.Residence,
                        MobileNo = model.Contact.MobileNo,
                        Office = model.Contact.Office,
                        Email = model.Contact.Email
                    };
                    bool result = false;
                    if (result == false)
                    {
                        _skulDbContext.Addresses.Add(address);
                        _skulDbContext.Contacts.Add(contact);
                        _skulDbContext.SaveChanges();
                        result = true;

                    }
                    else
                    {
                        _skulDbContext.Students.Remove(std);
                        _skulDbContext.SaveChanges();
                        ViewBag.Info = "Proccess could not be completed !";
                    }

                    if (result == true)
                    {
                        _skulDbContext.Add(std);
                        _skulDbContext.SaveChanges();
                        result = false;
                        return Redirect("Index");
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }
            return View();
        }
    }
}