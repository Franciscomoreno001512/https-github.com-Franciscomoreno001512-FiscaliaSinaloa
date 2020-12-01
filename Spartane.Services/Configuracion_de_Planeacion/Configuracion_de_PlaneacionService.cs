using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Configuracion_de_Planeacion;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Configuracion_de_Planeacion
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Configuracion_de_PlaneacionService : IConfiguracion_de_PlaneacionService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Configuracion_de_Planeacion.Configuracion_de_Planeacion> _Configuracion_de_PlaneacionRepository;
        #endregion

        #region Ctor
        public Configuracion_de_PlaneacionService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Configuracion_de_Planeacion.Configuracion_de_Planeacion> Configuracion_de_PlaneacionRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Configuracion_de_PlaneacionRepository = Configuracion_de_PlaneacionRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Configuracion_de_Planeacion.Configuracion_de_Planeacion> SelAll(bool ConRelaciones)
        {
            return this._Configuracion_de_PlaneacionRepository.Table.ToList();
        }

        public IList<Core.Domain.Configuracion_de_Planeacion.Configuracion_de_Planeacion> SelAllComplete(bool ConRelaciones)
        {
            return this._Configuracion_de_PlaneacionRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Configuracion_de_Planeacion.Configuracion_de_Planeacion> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Configuracion_de_PlaneacionRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Configuracion_de_Planeacion.Configuracion_de_Planeacion> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Configuracion_de_PlaneacionRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Configuracion_de_Planeacion.Configuracion_de_Planeacion> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Configuracion_de_PlaneacionRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Configuracion_de_Planeacion.Configuracion_de_PlaneacionPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Configuracion_de_PlaneacionPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Configuracion_de_Planeacion.Configuracion_de_Planeacion> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Configuracion_de_PlaneacionRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Configuracion_de_Planeacion.Configuracion_de_Planeacion GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Configuracion_de_Planeacion.Configuracion_de_Planeacion result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Configuracion_de_PlaneacionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Configuracion_de_Planeacion.Configuracion_de_Planeacion entity, Spartane.Core.Domain.User.GlobalData Configuracion_de_PlaneacionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Configuracion_de_Planeacion.Configuracion_de_Planeacion entity, Spartane.Core.Domain.User.GlobalData Configuracion_de_PlaneacionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

