﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using NLayerProject.WEB.DTOs;
using NLayerProject.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NLayerProject.WEB.Filters
{
    public class NotFoundFilter:ActionFilterAttribute
    {
        private readonly ICategoryService _categoryService;
        

        public NotFoundFilter(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async override Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            int id = (int)context.ActionArguments.Values.FirstOrDefault();
            var product = await _categoryService.GetByIdAsync(id);

            if (product!= null)
            {
                await next();
            }

            else
            {
                ErrorDto errorDto = new ErrorDto();

                errorDto.Errors.Add($"Id'si {id} olan kategori veri tabanında bulunamadı");
                context.Result = new RedirectToActionResult("Error", "Home", errorDto);


            }
        }
    }
}
