using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Detalle_Medios_Prueba_Imputado;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Detalle_Medios_Prueba_Imputado
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Detalle_Medios_Prueba_ImputadoService : IDetalle_Medios_Prueba_ImputadoService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Detalle_Medios_Prueba_Imputado.Detalle_Medios_Prueba_Imputado> _Detalle_Medios_Prueba_ImputadoRepository;
        #endregion

        #region Ctor
        public Detalle_Medios_Prueba_ImputadoService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Detalle_Medios_Prueba_Imputado.Detalle_Medios_Prueba_Imputado> Detalle_Medios_Prueba_ImputadoRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Detalle_Medios_Prueba_ImputadoRepository = Detalle_Medios_Prueba_ImputadoRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Detalle_Medios_Prueba_Imputado.Detalle_Medios_Prueba_Imputado> SelAll(bool ConRelaciones)
        {
            return this._Detalle_Medios_Prueba_ImputadoRepository.Table.ToList();
        }

        public IList<Core.Domain.Detalle_Medios_Prueba_Imputado.Detalle_Medios_Prueba_Imputado> SelAllComplete(bool ConRelaciones)
        {
            return this._Detalle_Medios_Prueba_ImputadoRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Detalle_Medios_Prueba_Imputado.Detalle_Medios_Prueba_Imputado> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_Medios_Prueba_ImputadoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_Medios_Prueba_Imputado.Detalle_Medios_Prueba_Imputado> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Detalle_Medios_Prueba_ImputadoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_Medios_Prueba_Imputado.Detalle_Medios_Prueba_Imputado> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_Medios_Prueba_ImputadoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_Medios_Prueba_Imputado.Detalle_Medios_Prueba_ImputadoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Detalle_Medios_Prueba_ImputadoPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Detalle_Medios_Prueba_Imputado.Detalle_Medios_Prueba_Imputado> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Detalle_Medios_Prueba_ImputadoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_Medios_Prueba_Imputado.Detalle_Medios_Prueba_Imputado GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Detalle_Medios_Prueba_Imputado.Detalle_Medios_Prueba_Imputado result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Detalle_Medios_Prueba_ImputadoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Detalle_Medios_Prueba_Imputado.Detalle_Medios_Prueba_Imputado entity, Spartane.Core.Domain.User.GlobalData Detalle_Medios_Prueba_ImputadoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Detalle_Medios_Prueba_Imputado.Detalle_Medios_Prueba_Imputado entity, Spartane.Core.Domain.User.GlobalData Detalle_Medios_Prueba_ImputadoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

