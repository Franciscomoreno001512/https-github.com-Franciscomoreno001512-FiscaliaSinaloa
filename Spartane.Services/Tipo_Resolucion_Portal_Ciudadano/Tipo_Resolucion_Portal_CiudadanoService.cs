using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Tipo_Resolucion_Portal_Ciudadano;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Tipo_Resolucion_Portal_Ciudadano
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Tipo_Resolucion_Portal_CiudadanoService : ITipo_Resolucion_Portal_CiudadanoService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Tipo_Resolucion_Portal_Ciudadano.Tipo_Resolucion_Portal_Ciudadano> _Tipo_Resolucion_Portal_CiudadanoRepository;
        #endregion

        #region Ctor
        public Tipo_Resolucion_Portal_CiudadanoService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Tipo_Resolucion_Portal_Ciudadano.Tipo_Resolucion_Portal_Ciudadano> Tipo_Resolucion_Portal_CiudadanoRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Tipo_Resolucion_Portal_CiudadanoRepository = Tipo_Resolucion_Portal_CiudadanoRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Tipo_Resolucion_Portal_Ciudadano.Tipo_Resolucion_Portal_Ciudadano> SelAll(bool ConRelaciones)
        {
            return this._Tipo_Resolucion_Portal_CiudadanoRepository.Table.ToList();
        }

        public IList<Core.Domain.Tipo_Resolucion_Portal_Ciudadano.Tipo_Resolucion_Portal_Ciudadano> SelAllComplete(bool ConRelaciones)
        {
            return this._Tipo_Resolucion_Portal_CiudadanoRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Tipo_Resolucion_Portal_Ciudadano.Tipo_Resolucion_Portal_Ciudadano> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Tipo_Resolucion_Portal_CiudadanoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Tipo_Resolucion_Portal_Ciudadano.Tipo_Resolucion_Portal_Ciudadano> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Tipo_Resolucion_Portal_CiudadanoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Tipo_Resolucion_Portal_Ciudadano.Tipo_Resolucion_Portal_Ciudadano> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Tipo_Resolucion_Portal_CiudadanoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Tipo_Resolucion_Portal_Ciudadano.Tipo_Resolucion_Portal_CiudadanoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Tipo_Resolucion_Portal_CiudadanoPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Tipo_Resolucion_Portal_Ciudadano.Tipo_Resolucion_Portal_Ciudadano> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Tipo_Resolucion_Portal_CiudadanoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Tipo_Resolucion_Portal_Ciudadano.Tipo_Resolucion_Portal_Ciudadano GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Tipo_Resolucion_Portal_Ciudadano.Tipo_Resolucion_Portal_Ciudadano result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Tipo_Resolucion_Portal_CiudadanoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Tipo_Resolucion_Portal_Ciudadano.Tipo_Resolucion_Portal_Ciudadano entity, Spartane.Core.Domain.User.GlobalData Tipo_Resolucion_Portal_CiudadanoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Tipo_Resolucion_Portal_Ciudadano.Tipo_Resolucion_Portal_Ciudadano entity, Spartane.Core.Domain.User.GlobalData Tipo_Resolucion_Portal_CiudadanoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

