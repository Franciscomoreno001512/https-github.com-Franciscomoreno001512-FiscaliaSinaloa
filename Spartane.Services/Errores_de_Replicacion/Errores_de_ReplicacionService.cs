using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Errores_de_Replicacion;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Errores_de_Replicacion
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Errores_de_ReplicacionService : IErrores_de_ReplicacionService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Errores_de_Replicacion.Errores_de_Replicacion> _Errores_de_ReplicacionRepository;
        #endregion

        #region Ctor
        public Errores_de_ReplicacionService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Errores_de_Replicacion.Errores_de_Replicacion> Errores_de_ReplicacionRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Errores_de_ReplicacionRepository = Errores_de_ReplicacionRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Errores_de_Replicacion.Errores_de_Replicacion> SelAll(bool ConRelaciones)
        {
            return this._Errores_de_ReplicacionRepository.Table.ToList();
        }

        public IList<Core.Domain.Errores_de_Replicacion.Errores_de_Replicacion> SelAllComplete(bool ConRelaciones)
        {
            return this._Errores_de_ReplicacionRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Errores_de_Replicacion.Errores_de_Replicacion> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Errores_de_ReplicacionRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Errores_de_Replicacion.Errores_de_Replicacion> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Errores_de_ReplicacionRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Errores_de_Replicacion.Errores_de_Replicacion> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Errores_de_ReplicacionRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Errores_de_Replicacion.Errores_de_ReplicacionPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Errores_de_ReplicacionPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Errores_de_Replicacion.Errores_de_Replicacion> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Errores_de_ReplicacionRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Errores_de_Replicacion.Errores_de_Replicacion GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Errores_de_Replicacion.Errores_de_Replicacion result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Errores_de_ReplicacionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Errores_de_Replicacion.Errores_de_Replicacion entity, Spartane.Core.Domain.User.GlobalData Errores_de_ReplicacionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Errores_de_Replicacion.Errores_de_Replicacion entity, Spartane.Core.Domain.User.GlobalData Errores_de_ReplicacionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

