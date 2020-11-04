using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Bigote;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Bigote
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class BigoteService : IBigoteService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Bigote.Bigote> _BigoteRepository;
        #endregion

        #region Ctor
        public BigoteService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Bigote.Bigote> BigoteRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._BigoteRepository = BigoteRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Bigote.Bigote> SelAll(bool ConRelaciones)
        {
            return this._BigoteRepository.Table.ToList();
        }

        public IList<Core.Domain.Bigote.Bigote> SelAllComplete(bool ConRelaciones)
        {
            return this._BigoteRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Bigote.Bigote> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._BigoteRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Bigote.Bigote> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._BigoteRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Bigote.Bigote> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._BigoteRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Bigote.BigotePagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            BigotePagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Bigote.Bigote> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._BigoteRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Bigote.Bigote GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Bigote.Bigote result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData BigoteInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Bigote.Bigote entity, Spartane.Core.Domain.User.GlobalData BigoteInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Bigote.Bigote entity, Spartane.Core.Domain.User.GlobalData BigoteInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

