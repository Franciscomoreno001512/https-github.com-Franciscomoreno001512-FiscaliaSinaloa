using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Personas_donde_se_ejecuto_mandamiento;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Personas_donde_se_ejecuto_mandamiento
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Personas_donde_se_ejecuto_mandamientoService : IPersonas_donde_se_ejecuto_mandamientoService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Personas_donde_se_ejecuto_mandamiento.Personas_donde_se_ejecuto_mandamiento> _Personas_donde_se_ejecuto_mandamientoRepository;
        #endregion

        #region Ctor
        public Personas_donde_se_ejecuto_mandamientoService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Personas_donde_se_ejecuto_mandamiento.Personas_donde_se_ejecuto_mandamiento> Personas_donde_se_ejecuto_mandamientoRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Personas_donde_se_ejecuto_mandamientoRepository = Personas_donde_se_ejecuto_mandamientoRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Personas_donde_se_ejecuto_mandamiento.Personas_donde_se_ejecuto_mandamiento> SelAll(bool ConRelaciones)
        {
            return this._Personas_donde_se_ejecuto_mandamientoRepository.Table.ToList();
        }

        public IList<Core.Domain.Personas_donde_se_ejecuto_mandamiento.Personas_donde_se_ejecuto_mandamiento> SelAllComplete(bool ConRelaciones)
        {
            return this._Personas_donde_se_ejecuto_mandamientoRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Personas_donde_se_ejecuto_mandamiento.Personas_donde_se_ejecuto_mandamiento> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Personas_donde_se_ejecuto_mandamientoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Personas_donde_se_ejecuto_mandamiento.Personas_donde_se_ejecuto_mandamiento> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Personas_donde_se_ejecuto_mandamientoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Personas_donde_se_ejecuto_mandamiento.Personas_donde_se_ejecuto_mandamiento> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Personas_donde_se_ejecuto_mandamientoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Personas_donde_se_ejecuto_mandamiento.Personas_donde_se_ejecuto_mandamientoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Personas_donde_se_ejecuto_mandamientoPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Personas_donde_se_ejecuto_mandamiento.Personas_donde_se_ejecuto_mandamiento> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Personas_donde_se_ejecuto_mandamientoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Personas_donde_se_ejecuto_mandamiento.Personas_donde_se_ejecuto_mandamiento GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Personas_donde_se_ejecuto_mandamiento.Personas_donde_se_ejecuto_mandamiento result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Personas_donde_se_ejecuto_mandamientoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Personas_donde_se_ejecuto_mandamiento.Personas_donde_se_ejecuto_mandamiento entity, Spartane.Core.Domain.User.GlobalData Personas_donde_se_ejecuto_mandamientoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Personas_donde_se_ejecuto_mandamiento.Personas_donde_se_ejecuto_mandamiento entity, Spartane.Core.Domain.User.GlobalData Personas_donde_se_ejecuto_mandamientoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

