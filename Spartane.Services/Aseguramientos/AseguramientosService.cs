using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Aseguramientos;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Aseguramientos
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class AseguramientosService : IAseguramientosService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Aseguramientos.Aseguramientos> _AseguramientosRepository;
        #endregion

        #region Ctor
        public AseguramientosService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Aseguramientos.Aseguramientos> AseguramientosRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._AseguramientosRepository = AseguramientosRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Aseguramientos.Aseguramientos> SelAll(bool ConRelaciones)
        {
            return this._AseguramientosRepository.Table.ToList();
        }

        public IList<Core.Domain.Aseguramientos.Aseguramientos> SelAllComplete(bool ConRelaciones)
        {
            return this._AseguramientosRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Aseguramientos.Aseguramientos> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._AseguramientosRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Aseguramientos.Aseguramientos> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._AseguramientosRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Aseguramientos.Aseguramientos> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._AseguramientosRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Aseguramientos.AseguramientosPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            AseguramientosPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Aseguramientos.Aseguramientos> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._AseguramientosRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Aseguramientos.Aseguramientos GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Aseguramientos.Aseguramientos result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData AseguramientosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Aseguramientos.Aseguramientos entity, Spartane.Core.Domain.User.GlobalData AseguramientosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Aseguramientos.Aseguramientos entity, Spartane.Core.Domain.User.GlobalData AseguramientosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

