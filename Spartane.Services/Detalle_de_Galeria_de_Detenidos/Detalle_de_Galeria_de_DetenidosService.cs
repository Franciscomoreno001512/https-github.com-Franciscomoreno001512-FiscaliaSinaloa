using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Detalle_de_Galeria_de_Detenidos;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Detalle_de_Galeria_de_Detenidos
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Detalle_de_Galeria_de_DetenidosService : IDetalle_de_Galeria_de_DetenidosService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Detalle_de_Galeria_de_Detenidos.Detalle_de_Galeria_de_Detenidos> _Detalle_de_Galeria_de_DetenidosRepository;
        #endregion

        #region Ctor
        public Detalle_de_Galeria_de_DetenidosService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Detalle_de_Galeria_de_Detenidos.Detalle_de_Galeria_de_Detenidos> Detalle_de_Galeria_de_DetenidosRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Detalle_de_Galeria_de_DetenidosRepository = Detalle_de_Galeria_de_DetenidosRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Detalle_de_Galeria_de_Detenidos.Detalle_de_Galeria_de_Detenidos> SelAll(bool ConRelaciones)
        {
            return this._Detalle_de_Galeria_de_DetenidosRepository.Table.ToList();
        }

        public IList<Core.Domain.Detalle_de_Galeria_de_Detenidos.Detalle_de_Galeria_de_Detenidos> SelAllComplete(bool ConRelaciones)
        {
            return this._Detalle_de_Galeria_de_DetenidosRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Detalle_de_Galeria_de_Detenidos.Detalle_de_Galeria_de_Detenidos> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_de_Galeria_de_DetenidosRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_de_Galeria_de_Detenidos.Detalle_de_Galeria_de_Detenidos> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Detalle_de_Galeria_de_DetenidosRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_de_Galeria_de_Detenidos.Detalle_de_Galeria_de_Detenidos> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_de_Galeria_de_DetenidosRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_de_Galeria_de_Detenidos.Detalle_de_Galeria_de_DetenidosPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Detalle_de_Galeria_de_DetenidosPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Detalle_de_Galeria_de_Detenidos.Detalle_de_Galeria_de_Detenidos> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Detalle_de_Galeria_de_DetenidosRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_de_Galeria_de_Detenidos.Detalle_de_Galeria_de_Detenidos GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Detalle_de_Galeria_de_Detenidos.Detalle_de_Galeria_de_Detenidos result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Detalle_de_Galeria_de_DetenidosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Detalle_de_Galeria_de_Detenidos.Detalle_de_Galeria_de_Detenidos entity, Spartane.Core.Domain.User.GlobalData Detalle_de_Galeria_de_DetenidosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Detalle_de_Galeria_de_Detenidos.Detalle_de_Galeria_de_Detenidos entity, Spartane.Core.Domain.User.GlobalData Detalle_de_Galeria_de_DetenidosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

