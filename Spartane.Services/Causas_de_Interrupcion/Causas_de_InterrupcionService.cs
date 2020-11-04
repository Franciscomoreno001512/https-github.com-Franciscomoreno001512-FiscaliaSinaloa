using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Causas_de_Interrupcion;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Causas_de_Interrupcion
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Causas_de_InterrupcionService : ICausas_de_InterrupcionService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Causas_de_Interrupcion.Causas_de_Interrupcion> _Causas_de_InterrupcionRepository;
        #endregion

        #region Ctor
        public Causas_de_InterrupcionService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Causas_de_Interrupcion.Causas_de_Interrupcion> Causas_de_InterrupcionRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Causas_de_InterrupcionRepository = Causas_de_InterrupcionRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Causas_de_Interrupcion.Causas_de_Interrupcion> SelAll(bool ConRelaciones)
        {
            return this._Causas_de_InterrupcionRepository.Table.ToList();
        }

        public IList<Core.Domain.Causas_de_Interrupcion.Causas_de_Interrupcion> SelAllComplete(bool ConRelaciones)
        {
            return this._Causas_de_InterrupcionRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Causas_de_Interrupcion.Causas_de_Interrupcion> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Causas_de_InterrupcionRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Causas_de_Interrupcion.Causas_de_Interrupcion> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Causas_de_InterrupcionRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Causas_de_Interrupcion.Causas_de_Interrupcion> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Causas_de_InterrupcionRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Causas_de_Interrupcion.Causas_de_InterrupcionPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Causas_de_InterrupcionPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Causas_de_Interrupcion.Causas_de_Interrupcion> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Causas_de_InterrupcionRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Causas_de_Interrupcion.Causas_de_Interrupcion GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Causas_de_Interrupcion.Causas_de_Interrupcion result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Causas_de_InterrupcionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Causas_de_Interrupcion.Causas_de_Interrupcion entity, Spartane.Core.Domain.User.GlobalData Causas_de_InterrupcionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Causas_de_Interrupcion.Causas_de_Interrupcion entity, Spartane.Core.Domain.User.GlobalData Causas_de_InterrupcionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

