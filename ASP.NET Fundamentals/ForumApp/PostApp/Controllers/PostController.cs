﻿using ForumApp.Core.Contracts;
using ForumApp.Core.Models;
using ForumApp.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace ForumApp.Controllers
{
    public class PostController(IPostService postService) : Controller
    {

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            IEnumerable<PostModel> model = await postService.GetAllPostsAsync();
            return View(model);
        }



        [HttpGet]
        public IActionResult Add()
        {
            var model = new PostModel(); //  Create new View model

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(PostModel model)
        {
            if (ModelState.IsValid == false)
            {
                return View(model);     // return same model
            }

            await postService.AddAsync(model);        // 
            return RedirectToAction(nameof(Index));
        }




        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            PostModel? model = await postService.GetByIdAsync(id);
            if (model == null)
            {
                ModelState.AddModelError("All", "Invalid Post!");
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(PostModel model)
        {
            if (ModelState.IsValid == false)
            {
                return View(model);
            }
            await postService.EditAsync(model);
            return RedirectToAction(nameof(Index));
        }



        public async Task<IActionResult> Delete(int id)
        {
            await postService.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
