﻿using FLEXCrm.Data;
using FLEXCrm.Interfaces;
using FLEXCrm.Models;
using FLEXCrm.Repositories.BaseRepository;
using Microsoft.EntityFrameworkCore;

namespace FLEXCrm.Repositories
{
    public class TBLCRMGROUP_Repository : BaseRepository<TBLCRMGROUP>, ITBLCRMGROUP
    {
        public TBLCRMGROUP_Repository(FLEXBDContext _flexbdContext) : base(_flexbdContext)
        {

        }

        public void AddGroupInfo(TBLCRMGROUP GroupInfo)
        {
            try
            {
                _flexbdContext.TBLCRMGROUP.Add(GroupInfo);
                _flexbdContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public bool CheckGroupInfo(int id)
        {
            return _flexbdContext.TBLCRMGROUP.Any(e => e.CRGID == id.ToString());
        }

        public TBLCRMGROUP DeleteGroupInfo(int id)
        {
            try
            {
                TBLCRMGROUP? GroupInfo = _flexbdContext.TBLCRMGROUP.Find(id);

                if (GroupInfo != null)
                {
                    _flexbdContext.TBLCRMGROUP.Remove(GroupInfo);
                    _flexbdContext.SaveChanges();
                    return GroupInfo;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch
            {
                throw;
            }
        }

        public TBLCRMGROUP GetGroupDetails(int id)
        {
            try
            {
                TBLCRMGROUP? GroupInfo = _flexbdContext.TBLCRMGROUP.Find(id);
                if (GroupInfo != null)
                {
                    return GroupInfo;
                }
                else
                {
                    return GroupInfo;
                }
            }
            catch
            {
                throw;
            }
        }

        public List<TBLCRMGROUP> GetGroupInfoList()
        {
            try
            {
                return _flexbdContext.TBLCRMGROUP.ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void UpdateGroupInfo(TBLCRMGROUP GroupInfo)
        {
            try
            {
                _flexbdContext.Entry(GroupInfo).State = EntityState.Modified;
                _flexbdContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
