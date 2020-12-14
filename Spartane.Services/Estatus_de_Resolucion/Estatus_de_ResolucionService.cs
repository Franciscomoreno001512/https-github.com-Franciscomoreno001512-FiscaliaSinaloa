using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Estatus_de_Resolucion;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Estatus_de_Resolucion
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Estatus_de_ResolucionService : IEstatus_de_ResolucionService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Estatus_de_Resolucion.Estatus_de_Resolucion> _Estatus_de_ResolucionRepository;
        #endregion

        #region Ctor
        public Estatus_de_ResolucionService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Estatus_de_Resolucion.Estatus_de_Resolucion> Estatus_de_ResolucionRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Estatus_de_ResolucionRepository = Estatus_de_ResolucionRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Estatus_de_Resolucion.Estatus_de_Resolucion> SelAll(bool ConRelaciones)
        {
            return this._Estatus_de_ResolucionRepository.Table.ToList();
        }

        public IList<Core.Domain.Estatus_de_Resolucion.Estatus_de_Resolucion> SelAllComplete(bool ConRelaciones)
        {
            return this._Estatus_de_ResolucionRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Estatus_de_Resolucion.Estatus_de_Resolucion> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Estatus_de_ResolucionRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Estatus_de_Resolucion.Estatus_de_Resolucion> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Estatus_de_ResolucionRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Estatus_de_Resolucion.Estatus_de_Resolucion> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Estatus_de_ResolucionRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Estatus_de_Resolucion.Estatus_de_ResolucionPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Estatus_de_ResolucionPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Estatus_de_Resolucion.Estatus_de_Resolucion> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Estatus_de_ResolucionRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Estatus_de_Resolucion.Estatus_de_Resolucion GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Estatus_de_Resolucion.Estatus_de_Resolucion result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Estatus_de_ResolucionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Estatus_de_Resolucion.Estatus_de_Resolucion entity, Spartane.Core.Domain.User.GlobalData Estatus_de_ResolucionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Estatus_de_Resolucion.Estatus_de_Resolucion entity, Spartane.Core.Domain.User.GlobalData Estatus_de_ResolucionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

