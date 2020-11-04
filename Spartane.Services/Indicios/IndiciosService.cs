using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Indicios;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Indicios
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class IndiciosService : IIndiciosService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Indicios.Indicios> _IndiciosRepository;
        #endregion

        #region Ctor
        public IndiciosService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Indicios.Indicios> IndiciosRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._IndiciosRepository = IndiciosRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Indicios.Indicios> SelAll(bool ConRelaciones)
        {
            return this._IndiciosRepository.Table.ToList();
        }

        public IList<Core.Domain.Indicios.Indicios> SelAllComplete(bool ConRelaciones)
        {
            return this._IndiciosRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Indicios.Indicios> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._IndiciosRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Indicios.Indicios> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._IndiciosRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Indicios.Indicios> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._IndiciosRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Indicios.IndiciosPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            IndiciosPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Indicios.Indicios> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._IndiciosRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Indicios.Indicios GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Indicios.Indicios result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData IndiciosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Indicios.Indicios entity, Spartane.Core.Domain.User.GlobalData IndiciosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Indicios.Indicios entity, Spartane.Core.Domain.User.GlobalData IndiciosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

