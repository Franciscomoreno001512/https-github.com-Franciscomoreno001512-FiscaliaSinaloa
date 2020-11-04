using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Indigena;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Indigena
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class IndigenaService : IIndigenaService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Indigena.Indigena> _IndigenaRepository;
        #endregion

        #region Ctor
        public IndigenaService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Indigena.Indigena> IndigenaRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._IndigenaRepository = IndigenaRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Indigena.Indigena> SelAll(bool ConRelaciones)
        {
            return this._IndigenaRepository.Table.ToList();
        }

        public IList<Core.Domain.Indigena.Indigena> SelAllComplete(bool ConRelaciones)
        {
            return this._IndigenaRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Indigena.Indigena> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._IndigenaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Indigena.Indigena> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._IndigenaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Indigena.Indigena> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._IndigenaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Indigena.IndigenaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            IndigenaPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Indigena.Indigena> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._IndigenaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Indigena.Indigena GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Indigena.Indigena result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData IndigenaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Indigena.Indigena entity, Spartane.Core.Domain.User.GlobalData IndigenaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Indigena.Indigena entity, Spartane.Core.Domain.User.GlobalData IndigenaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

