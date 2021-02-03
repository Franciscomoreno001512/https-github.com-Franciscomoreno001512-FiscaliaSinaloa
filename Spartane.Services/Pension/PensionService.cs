using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Pension;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Pension
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class PensionService : IPensionService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Pension.Pension> _PensionRepository;
        #endregion

        #region Ctor
        public PensionService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Pension.Pension> PensionRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._PensionRepository = PensionRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Pension.Pension> SelAll(bool ConRelaciones)
        {
            return this._PensionRepository.Table.ToList();
        }

        public IList<Core.Domain.Pension.Pension> SelAllComplete(bool ConRelaciones)
        {
            return this._PensionRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Pension.Pension> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._PensionRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Pension.Pension> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._PensionRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Pension.Pension> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._PensionRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Pension.PensionPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            PensionPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Pension.Pension> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._PensionRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Pension.Pension GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Pension.Pension result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData PensionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Pension.Pension entity, Spartane.Core.Domain.User.GlobalData PensionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Pension.Pension entity, Spartane.Core.Domain.User.GlobalData PensionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

