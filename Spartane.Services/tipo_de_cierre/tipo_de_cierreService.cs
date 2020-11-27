using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.tipo_de_cierre;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.tipo_de_cierre
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class tipo_de_cierreService : Itipo_de_cierreService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.tipo_de_cierre.tipo_de_cierre> _tipo_de_cierreRepository;
        #endregion

        #region Ctor
        public tipo_de_cierreService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.tipo_de_cierre.tipo_de_cierre> tipo_de_cierreRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._tipo_de_cierreRepository = tipo_de_cierreRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.tipo_de_cierre.tipo_de_cierre> SelAll(bool ConRelaciones)
        {
            return this._tipo_de_cierreRepository.Table.ToList();
        }

        public IList<Core.Domain.tipo_de_cierre.tipo_de_cierre> SelAllComplete(bool ConRelaciones)
        {
            return this._tipo_de_cierreRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.tipo_de_cierre.tipo_de_cierre> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._tipo_de_cierreRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.tipo_de_cierre.tipo_de_cierre> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._tipo_de_cierreRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.tipo_de_cierre.tipo_de_cierre> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._tipo_de_cierreRepository.Table.ToList();
        }

        public Spartane.Core.Domain.tipo_de_cierre.tipo_de_cierrePagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            tipo_de_cierrePagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.tipo_de_cierre.tipo_de_cierre> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._tipo_de_cierreRepository.Table.ToList();
        }

        public Spartane.Core.Domain.tipo_de_cierre.tipo_de_cierre GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.tipo_de_cierre.tipo_de_cierre result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData tipo_de_cierreInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.tipo_de_cierre.tipo_de_cierre entity, Spartane.Core.Domain.User.GlobalData tipo_de_cierreInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.tipo_de_cierre.tipo_de_cierre entity, Spartane.Core.Domain.User.GlobalData tipo_de_cierreInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

