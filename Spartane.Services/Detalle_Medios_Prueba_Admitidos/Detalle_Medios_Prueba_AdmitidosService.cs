using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Detalle_Medios_Prueba_Admitidos;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Detalle_Medios_Prueba_Admitidos
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Detalle_Medios_Prueba_AdmitidosService : IDetalle_Medios_Prueba_AdmitidosService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Detalle_Medios_Prueba_Admitidos.Detalle_Medios_Prueba_Admitidos> _Detalle_Medios_Prueba_AdmitidosRepository;
        #endregion

        #region Ctor
        public Detalle_Medios_Prueba_AdmitidosService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Detalle_Medios_Prueba_Admitidos.Detalle_Medios_Prueba_Admitidos> Detalle_Medios_Prueba_AdmitidosRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Detalle_Medios_Prueba_AdmitidosRepository = Detalle_Medios_Prueba_AdmitidosRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Detalle_Medios_Prueba_Admitidos.Detalle_Medios_Prueba_Admitidos> SelAll(bool ConRelaciones)
        {
            return this._Detalle_Medios_Prueba_AdmitidosRepository.Table.ToList();
        }

        public IList<Core.Domain.Detalle_Medios_Prueba_Admitidos.Detalle_Medios_Prueba_Admitidos> SelAllComplete(bool ConRelaciones)
        {
            return this._Detalle_Medios_Prueba_AdmitidosRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Detalle_Medios_Prueba_Admitidos.Detalle_Medios_Prueba_Admitidos> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_Medios_Prueba_AdmitidosRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_Medios_Prueba_Admitidos.Detalle_Medios_Prueba_Admitidos> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Detalle_Medios_Prueba_AdmitidosRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_Medios_Prueba_Admitidos.Detalle_Medios_Prueba_Admitidos> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_Medios_Prueba_AdmitidosRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_Medios_Prueba_Admitidos.Detalle_Medios_Prueba_AdmitidosPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Detalle_Medios_Prueba_AdmitidosPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Detalle_Medios_Prueba_Admitidos.Detalle_Medios_Prueba_Admitidos> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Detalle_Medios_Prueba_AdmitidosRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_Medios_Prueba_Admitidos.Detalle_Medios_Prueba_Admitidos GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Detalle_Medios_Prueba_Admitidos.Detalle_Medios_Prueba_Admitidos result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Detalle_Medios_Prueba_AdmitidosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Detalle_Medios_Prueba_Admitidos.Detalle_Medios_Prueba_Admitidos entity, Spartane.Core.Domain.User.GlobalData Detalle_Medios_Prueba_AdmitidosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Detalle_Medios_Prueba_Admitidos.Detalle_Medios_Prueba_Admitidos entity, Spartane.Core.Domain.User.GlobalData Detalle_Medios_Prueba_AdmitidosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

