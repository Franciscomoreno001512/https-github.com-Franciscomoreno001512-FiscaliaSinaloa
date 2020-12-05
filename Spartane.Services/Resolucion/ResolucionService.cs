using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Resolucion;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Resolucion
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class ResolucionService : IResolucionService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Resolucion.Resolucion> _ResolucionRepository;
        #endregion

        #region Ctor
        public ResolucionService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Resolucion.Resolucion> ResolucionRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._ResolucionRepository = ResolucionRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Resolucion.Resolucion> SelAll(bool ConRelaciones)
        {
            return this._ResolucionRepository.Table.ToList();
        }

        public IList<Core.Domain.Resolucion.Resolucion> SelAllComplete(bool ConRelaciones)
        {
            return this._ResolucionRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Resolucion.Resolucion> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._ResolucionRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Resolucion.Resolucion> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._ResolucionRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Resolucion.Resolucion> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._ResolucionRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Resolucion.ResolucionPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            ResolucionPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Resolucion.Resolucion> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._ResolucionRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Resolucion.Resolucion GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Resolucion.Resolucion result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData ResolucionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Resolucion.Resolucion entity, Spartane.Core.Domain.User.GlobalData ResolucionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Resolucion.Resolucion entity, Spartane.Core.Domain.User.GlobalData ResolucionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

