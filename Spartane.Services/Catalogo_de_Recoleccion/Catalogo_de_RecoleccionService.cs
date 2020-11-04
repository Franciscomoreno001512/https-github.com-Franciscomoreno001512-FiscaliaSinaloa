using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Catalogo_de_Recoleccion;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Catalogo_de_Recoleccion
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Catalogo_de_RecoleccionService : ICatalogo_de_RecoleccionService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Catalogo_de_Recoleccion.Catalogo_de_Recoleccion> _Catalogo_de_RecoleccionRepository;
        #endregion

        #region Ctor
        public Catalogo_de_RecoleccionService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Catalogo_de_Recoleccion.Catalogo_de_Recoleccion> Catalogo_de_RecoleccionRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Catalogo_de_RecoleccionRepository = Catalogo_de_RecoleccionRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Catalogo_de_Recoleccion.Catalogo_de_Recoleccion> SelAll(bool ConRelaciones)
        {
            return this._Catalogo_de_RecoleccionRepository.Table.ToList();
        }

        public IList<Core.Domain.Catalogo_de_Recoleccion.Catalogo_de_Recoleccion> SelAllComplete(bool ConRelaciones)
        {
            return this._Catalogo_de_RecoleccionRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Catalogo_de_Recoleccion.Catalogo_de_Recoleccion> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Catalogo_de_RecoleccionRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Catalogo_de_Recoleccion.Catalogo_de_Recoleccion> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Catalogo_de_RecoleccionRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Catalogo_de_Recoleccion.Catalogo_de_Recoleccion> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Catalogo_de_RecoleccionRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Catalogo_de_Recoleccion.Catalogo_de_RecoleccionPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Catalogo_de_RecoleccionPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Catalogo_de_Recoleccion.Catalogo_de_Recoleccion> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Catalogo_de_RecoleccionRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Catalogo_de_Recoleccion.Catalogo_de_Recoleccion GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Catalogo_de_Recoleccion.Catalogo_de_Recoleccion result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Catalogo_de_RecoleccionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Catalogo_de_Recoleccion.Catalogo_de_Recoleccion entity, Spartane.Core.Domain.User.GlobalData Catalogo_de_RecoleccionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Catalogo_de_Recoleccion.Catalogo_de_Recoleccion entity, Spartane.Core.Domain.User.GlobalData Catalogo_de_RecoleccionInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

