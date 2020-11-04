using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Modulo;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Modulo
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class ModuloService : IModuloService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Modulo.Modulo> _ModuloRepository;
        #endregion

        #region Ctor
        public ModuloService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Modulo.Modulo> ModuloRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._ModuloRepository = ModuloRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Modulo.Modulo> SelAll(bool ConRelaciones)
        {
            return this._ModuloRepository.Table.ToList();
        }

        public IList<Core.Domain.Modulo.Modulo> SelAllComplete(bool ConRelaciones)
        {
            return this._ModuloRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Modulo.Modulo> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._ModuloRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Modulo.Modulo> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._ModuloRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Modulo.Modulo> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._ModuloRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Modulo.ModuloPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            ModuloPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Modulo.Modulo> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._ModuloRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Modulo.Modulo GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Modulo.Modulo result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData ModuloInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Modulo.Modulo entity, Spartane.Core.Domain.User.GlobalData ModuloInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Modulo.Modulo entity, Spartane.Core.Domain.User.GlobalData ModuloInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

