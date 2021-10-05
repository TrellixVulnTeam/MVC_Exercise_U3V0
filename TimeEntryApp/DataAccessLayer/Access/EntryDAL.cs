﻿using BusinessObjectLayer.Data;
using BusinessObjectLayer.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Access
{
    public class EntryDAL
    {
        private readonly TimeEntryAppContext _db;
        private readonly AppDbContext _appDb;
        public EntryDAL(TimeEntryAppContext db,AppDbContext appDb)
        {
            this._db = db;
            _appDb = appDb;
        }

        public TimeEntry GetEntry(string id)
        {
            var entries = _db.Entries.Find(id);

            return entries;
        }

        public List<TimeEntry> GetEntry()
        {
            var entries = _db.Entries.ToList();

            return entries;
        }

        public void SetEntry(TimeEntry entry)
        {
            _db.Entries.Add(entry);
        }

        public void SetBreak(IList<Break> brks)
        {

            foreach (var brk in brks)
            {
                _db.Breaks.Add(brk);
            }
        }

    }
}
