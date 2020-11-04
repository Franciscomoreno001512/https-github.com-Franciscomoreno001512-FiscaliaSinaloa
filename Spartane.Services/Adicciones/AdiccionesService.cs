using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Adicciones;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Adicciones
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class AdiccionesService : IAdiccionesService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Adicciones.Adicciones> _AdiccionesRepository;
        #endregion

        #region Ctor
        public AdiccionesService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Adicciones.Adicciones> AdiccionesRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._AdiccionesRepository = AdiccionesRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Adicciones.Adicciones> SelAll(bool ConRelaciones)
        {
            return this._AdiccionesRepository.Table.ToList();
        }

        public IList<Core.Domain.Adicciones.Adicciones> SelAllComplete(bool ConRelaciones)
        {
            return this._AdiccionesRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Adicciones.Adicciones> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._AdiccionesRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Adicciones.Adicciones> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._AdiccionesRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Adicciones.Adicciones> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._AdiccionesRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Adicciones.AdiccionesPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            AdiccionesPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Adicciones.Adicciones> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._AdiccionesRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Adicciones.Adicciones GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Adicciones.Adicciones result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData AdiccionesInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Adicciones.Adicciones entity, Spartane.Core.Domain.User.GlobalData AdiccionesInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Adicciones.Adicciones entity, Spartane.Core.Domain.User.GlobalData AdiccionesInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

