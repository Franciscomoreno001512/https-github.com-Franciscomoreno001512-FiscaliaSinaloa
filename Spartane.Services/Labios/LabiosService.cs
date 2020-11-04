using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Labios;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Labios
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class LabiosService : ILabiosService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Labios.Labios> _LabiosRepository;
        #endregion

        #region Ctor
        public LabiosService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Labios.Labios> LabiosRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._LabiosRepository = LabiosRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Labios.Labios> SelAll(bool ConRelaciones)
        {
            return this._LabiosRepository.Table.ToList();
        }

        public IList<Core.Domain.Labios.Labios> SelAllComplete(bool ConRelaciones)
        {
            return this._LabiosRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Labios.Labios> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._LabiosRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Labios.Labios> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._LabiosRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Labios.Labios> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._LabiosRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Labios.LabiosPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            LabiosPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Labios.Labios> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._LabiosRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Labios.Labios GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Labios.Labios result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData LabiosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Labios.Labios entity, Spartane.Core.Domain.User.GlobalData LabiosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Labios.Labios entity, Spartane.Core.Domain.User.GlobalData LabiosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

