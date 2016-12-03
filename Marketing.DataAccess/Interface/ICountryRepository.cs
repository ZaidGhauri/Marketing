﻿using Marketing.Common;
using Marketing.Data;
using Marketing.DataAccess.Repositories.Core;
using System.Collections.Generic;

namespace Marketing.DataAccess.Interface
{
    public interface ICountryRepository : IWriteRepository
    {
        IEnumerable<Country> All();
    }
}