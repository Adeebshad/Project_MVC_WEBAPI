﻿using Basic.Domain.Interfaces;
using Basic.Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Basic.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientInfoController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        public PatientInfoController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet("GetPatientInfo")]
        public IEnumerable<PatientInfoStore> GetAllPersons()
        {
            //IEnumerable<PatientInfo> patientInfo = new Enumerable<PatientInfo>();
            //IEnumerable<PatientInfoStore> KL = unitOfWork.PatientInfoStore.GetAll();
            //foreach (PatientInfoStore fg in KL) {
            //    PatientInfo hj = new PatientInfo();

            //    var DiseaseName = unitOfWork.Diseases.GetById(int.Parse(fg.DiseasesName));
            //    var io = 34;
            //}
            // return patientInfo;
            return unitOfWork.PatientInfoStore.GetAll();
        }

        [HttpGet("GetPatientInfoById")]
        public IActionResult GetItemById(int id)
        {

            var item = unitOfWork.PatientInfoStore.GetById(id);
            if (item == null)
            {
                return NotFound(); // Returns a 404 Not Found response if the item with the specified ID is not found
            }
            return Ok(item); // Returns a 200 OK response with the item data if found
        }
        [HttpPut("UpdatePatientInfo")]
        public async Task<IActionResult> UpdateItem(PatientInfoStore item)
        {
            unitOfWork.PatientInfoStore.Update(item);
            unitOfWork.Save();
            return Ok();
        }

        [HttpDelete("RemoveItem")]
        public async Task<IActionResult> RemoveItem(int itemId)
        {
            PatientInfoStore getItem = new PatientInfoStore();
            getItem.Id = itemId;
            unitOfWork.PatientInfoStore.Remove(getItem);
            unitOfWork.Save();
            return Ok();
        }

        [HttpPost("AddPatientInfo")]
        public async Task<IActionResult> EnterItem([FromBody] PatientInfo patientInfo)
        {
            List<OtherNCD> er = new List<OtherNCD>();
            foreach (var item in patientInfo.OtherNCDs) {
                var otherNCD = new OtherNCD();
                otherNCD.Name = item;
                otherNCD.PatientInfoId = patientInfo.Id;
                er.Add(otherNCD);
            }
            List<OtherAllergy> ar = new List<OtherAllergy>();
            foreach (var item in patientInfo.Allergies)
            {
                var otherAllergy = new OtherAllergy();
                otherAllergy.Name = item;
                otherAllergy.PatientInfoId = patientInfo.Id;
                ar.Add(otherAllergy);
            }
            PatientInfoStore Ps = new PatientInfoStore();
            Ps.OtherNCDs = er;
            Ps.PatientName = patientInfo.PatientName;
            Ps.DiseasesName = patientInfo.DiseasesName;
            Ps.Epilepsy = patientInfo.Epilepsy;
            Ps.Allergies = ar;

            unitOfWork.PatientInfoStore.Add(Ps);
            unitOfWork.Save();
            return Ok();
        }


    }
}
