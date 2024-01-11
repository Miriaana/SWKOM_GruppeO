/*
 * Paperless Rest Server
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
 * 
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using PaperlessRestAPI.Attributes;
using PaperlessRestAPI.Models;
using PaperlessRestAPI.BusinessLogic;
using PaperlessRestAPI.BusinessLogic.Interfaces.Components;

namespace PaperlessRestAPI.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class SearchApiController : ControllerBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="term"></param>
        /// <param name="limit"></param>
        /// <response code="200">Success</response>
        [HttpGet]
        [Route("/api/search/autocomplete")]
        [ValidateModelState]
        [SwaggerOperation("AutoComplete")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<string>), description: "Success")]
        public virtual IActionResult AutoComplete([FromQuery(Name = "term")] string term, [FromQuery(Name = "limit")] int? limit, [FromServices] ISearchDocumentLogic searchDocument)
        {        
            return StatusCode(200, searchDocument.searchDocuments(term));    
        }
    }
}
