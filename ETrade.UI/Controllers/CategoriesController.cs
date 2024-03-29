﻿using ETrade.Entity.Concretes;
using ETrade.UI.Models;
using ETrade.Uw;
using Microsoft.AspNetCore.Mvc;

namespace ETrade.UI.Controllers
{
    public class CategoriesController : Controller
    {
        IUnit _uow;
        CategoriesModel _model;
        public CategoriesController(IUnit uow, CategoriesModel model)
        {
            _uow = uow;
            _model = model;
        }
        public IActionResult List()
        {
            var clist = _uow._categoriesRep.List();
            return View(clist);
        }

        public IActionResult Create()
        {
            _model.Head = "Create New";
            _model.Text = "Save";
            _model.Cls = "btn btn-primary";
            _model.Categories = new Categories();
            return View("Crud", _model);
        }

        [HttpPost]
        public IActionResult Create(CategoriesModel m)
        {

            _uow._categoriesRep.Add(m.Categories);
            _uow.Commit();
            return RedirectToAction("List");
        }

        public IActionResult Delete(int Id)
        {
            _model.Head = "Delete";
            _model.Text = "OK";
            _model.Cls = "btn btn-danger";
            _model.Categories = _uow._categoriesRep.Find(Id);
            return View("Crud", _model);
        }
        [HttpPost]
        public IActionResult Delete(CategoriesModel model)
        {

            _uow._categoriesRep.Delete(model.Categories.Id);
            _uow.Commit();
            return RedirectToAction("List");
        }

        public IActionResult Edit(int Id)
        {
            _model.Head = "Update";
            _model.Text = "OK";
            _model.Cls = "btn btn-success";
            _model.Categories = _uow._categoriesRep.Find(Id);
            return View("Crud", _model);
        }
        [HttpPost]
        public IActionResult Edit(CategoriesModel c)
        {
            _uow._categoriesRep.Update(c.Categories);
            _uow.Commit();
            return RedirectToAction("List");
        }
    }
}
