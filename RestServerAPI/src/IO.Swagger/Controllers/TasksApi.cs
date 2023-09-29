/*
 * Paperless Rest Server
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using PaperlessRestApi.Attributes;

using Microsoft.AspNetCore.Authorization;
using PaperlessRestApi.Models;

namespace PaperlessRestApi.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class TasksApiController : ControllerBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="body"></param>
        /// <response code="200">Success</response>
        [HttpPost]
        [Route("/api/acknowledge_tasks")]
        [ValidateModelState]
        [SwaggerOperation("AckTasks")]
        [SwaggerResponse(statusCode: 200, type: typeof(InlineResponse20020), description: "Success")]
        public virtual IActionResult AckTasks([FromBody] ApiAcknowledgeTasksBody body)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(InlineResponse20020));
            string exampleJson = null;
            exampleJson = "{\n  \"result\" : 0\n}";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<InlineResponse20020>(exampleJson)
            : default;            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <response code="200">Success</response>
        [HttpGet]
        [Route("/api/tasks")]
        [ValidateModelState]
        [SwaggerOperation("GetTasks")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<InlineResponse20019>), description: "Success")]
        public virtual IActionResult GetTasks()
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<InlineResponse20019>));
            string exampleJson = null;
            exampleJson = "[ {\n  \"date_done\" : \"date_done\",\n  \"result\" : \"result\",\n  \"acknowledged\" : true,\n  \"task_file_name\" : \"task_file_name\",\n  \"date_created\" : \"date_created\",\n  \"related_document\" : \"related_document\",\n  \"task_id\" : \"task_id\",\n  \"id\" : 0,\n  \"type\" : \"type\",\n  \"status\" : \"status\"\n}, {\n  \"date_done\" : \"date_done\",\n  \"result\" : \"result\",\n  \"acknowledged\" : true,\n  \"task_file_name\" : \"task_file_name\",\n  \"date_created\" : \"date_created\",\n  \"related_document\" : \"related_document\",\n  \"task_id\" : \"task_id\",\n  \"id\" : 0,\n  \"type\" : \"type\",\n  \"status\" : \"status\"\n} ]";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<InlineResponse20019>>(exampleJson)
            : default;            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
