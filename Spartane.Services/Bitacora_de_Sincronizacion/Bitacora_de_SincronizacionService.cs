using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Bitacora_de_Sincronizacion;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Bitacora_de_Sincronizacion
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Bitacora_de_SincronizacionService : IBitacora_de_SincronizacionService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Bitacora_de_Sincronizacion.Bitacora_de_Sincronizacion> _Bitacora_de_SincronizacionRepository;
        #endregion

        #region Ctor
        public Bitacora_de_SincronizacionService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Bitacora_de_Sincronizacion.Bitacora_de_Sincronizacion> Bitacora_de_SincronizacionRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Bitacora_de_SincronizacionRepository = Bitacora_de_SincronizacionRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Bitacora_de_Sincronizacion.Bitacora_de_Sincronizacion> SelAll(bool ConRelaciones)
        {
            return this._Bitacora_de_SincronizacionRepository.Table.ToList();
        }

        public IList<Core.Domain.Bitacora_de_Sincronizacion.Bitacora_de_Sincronizacion> SelAllComplete(bool ConRelaciones)
        {
            return this._Bitacora_de_SincronizacionRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Bitacora_de_Sincronizacion.Bitacora_de_Sincronizacion> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Bitacora_de_SincronizacionRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Bitacora_de_Sincronizacion.Bitacora_de_Sincronizacion> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Bitacora_de_SincronizacionRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Bitacora_de_Sincronizacion.Bitacora_de_Sincronizacion> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Bitacora_de_SincronizacionRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Bitacora_de_Sincronizacion.Bitacora_de_SincronizacionPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Bitacora_de_SincronizacionPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Bitacora_de_Sincronizacion.Bitacora_de_Sincronizacion> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Bitacora_de_SincronizacionRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Bitacora_de_Sincronizacion.Bitacora_de_Sincronizacion GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Bitacora_de_Sincronizacion.Bitacora_de_Sincronizacion result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Bitacora_de_SincronizacionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Bitacora_de_Sincronizacion.Bitacora_de_Sincronizacion entity, Spartane.Core.Domain.User.GlobalData Bitacora_de_SincronizacionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Bitacora_de_Sincronizacion.Bitacora_de_Sincronizacion entity, Spartane.Core.Domain.User.GlobalData Bitacora_de_SincronizacionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

