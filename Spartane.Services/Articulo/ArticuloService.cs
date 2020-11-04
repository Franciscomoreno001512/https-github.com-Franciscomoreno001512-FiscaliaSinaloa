using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Articulo;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Articulo
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class ArticuloService : IArticuloService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Articulo.Articulo> _ArticuloRepository;
        #endregion

        #region Ctor
        public ArticuloService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Articulo.Articulo> ArticuloRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._ArticuloRepository = ArticuloRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Articulo.Articulo> SelAll(bool ConRelaciones)
        {
            return this._ArticuloRepository.Table.ToList();
        }

        public IList<Core.Domain.Articulo.Articulo> SelAllComplete(bool ConRelaciones)
        {
            return this._ArticuloRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Articulo.Articulo> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._ArticuloRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Articulo.Articulo> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._ArticuloRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Articulo.Articulo> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._ArticuloRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Articulo.ArticuloPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            ArticuloPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Articulo.Articulo> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._ArticuloRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Articulo.Articulo GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Articulo.Articulo result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData ArticuloInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Articulo.Articulo entity, Spartane.Core.Domain.User.GlobalData ArticuloInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Articulo.Articulo entity, Spartane.Core.Domain.User.GlobalData ArticuloInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

