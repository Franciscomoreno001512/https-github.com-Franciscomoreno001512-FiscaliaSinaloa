using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Continuacion_de_Proceso;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Continuacion_de_Proceso
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Continuacion_de_ProcesoService : IContinuacion_de_ProcesoService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Continuacion_de_Proceso.Continuacion_de_Proceso> _Continuacion_de_ProcesoRepository;
        #endregion

        #region Ctor
        public Continuacion_de_ProcesoService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Continuacion_de_Proceso.Continuacion_de_Proceso> Continuacion_de_ProcesoRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Continuacion_de_ProcesoRepository = Continuacion_de_ProcesoRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Continuacion_de_Proceso.Continuacion_de_Proceso> SelAll(bool ConRelaciones)
        {
            return this._Continuacion_de_ProcesoRepository.Table.ToList();
        }

        public IList<Core.Domain.Continuacion_de_Proceso.Continuacion_de_Proceso> SelAllComplete(bool ConRelaciones)
        {
            return this._Continuacion_de_ProcesoRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Continuacion_de_Proceso.Continuacion_de_Proceso> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Continuacion_de_ProcesoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Continuacion_de_Proceso.Continuacion_de_Proceso> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Continuacion_de_ProcesoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Continuacion_de_Proceso.Continuacion_de_Proceso> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Continuacion_de_ProcesoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Continuacion_de_Proceso.Continuacion_de_ProcesoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Continuacion_de_ProcesoPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Continuacion_de_Proceso.Continuacion_de_Proceso> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Continuacion_de_ProcesoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Continuacion_de_Proceso.Continuacion_de_Proceso GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Continuacion_de_Proceso.Continuacion_de_Proceso result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Continuacion_de_ProcesoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Continuacion_de_Proceso.Continuacion_de_Proceso entity, Spartane.Core.Domain.User.GlobalData Continuacion_de_ProcesoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Continuacion_de_Proceso.Continuacion_de_Proceso entity, Spartane.Core.Domain.User.GlobalData Continuacion_de_ProcesoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

