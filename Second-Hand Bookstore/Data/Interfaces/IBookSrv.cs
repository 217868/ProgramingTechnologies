﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.DataModels;

namespace Data.Interfaces
{
    public interface IBookSrv
    {
        void CreateBook(tBook book);
        tBook GetBook(int id);
        void UpdateBook(tBook book);
        void DeleteBook(int id);
        List<tBook> GetBookList();
        List<tBook> GetBooksBySupplier(string supplierName);
    }
}
