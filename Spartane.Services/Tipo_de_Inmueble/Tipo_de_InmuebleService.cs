using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Tipo_de_Inmueble;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Tipo_de_Inmueble
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Tipo_de_InmuebleService : ITipo_de_InmuebleService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Tipo_de_Inmueble.Tipo_de_Inmueble> _Tipo_de_InmuebleRepository;
        #endregion

        #region Ctor
        public Tipo_de_InmuebleService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Tipo_de_Inmueble.Tipo_de_Inmueble> Tipo_de_InmuebleRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Tipo_de_InmuebleRepository = Tipo_de_InmuebleRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Tipo_de_Inmueble.Tipo_de_Inmueble> SelAll(bool ConRelaciones)
        {
            return this._Tipo_de_InmuebleRepository.Table.ToList();
        }

        public IList<Core.Domain.Tipo_de_Inmueble.Tipo_de_Inmueble> SelAllComplete(bool ConRelaciones)
        {
            return this._Tipo_de_InmuebleRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Tipo_de_Inmueble.Tipo_de_Inmueble> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Tipo_de_InmuebleRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Tipo_de_Inmueble.Tipo_de_Inmueble> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Tipo_de_InmuebleRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Tipo_de_Inmueble.Tipo_de_Inmueble> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Tipo_de_InmuebleRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Tipo_de_Inmueble.Tipo_de_InmueblePagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Tipo_de_InmueblePagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Tipo_de_Inmueble.Tipo_de_Inmueble> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Tipo_de_InmuebleRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Tipo_de_Inmueble.Tipo_de_Inmueble GetByKey(short Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Tipo_de_Inmueble.Tipo_de_Inmueble result=null;
            return result;
        }

        public bool Delete(short Key, Spartane.Core.Domain.User.GlobalData Tipo_de_InmuebleInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public short Insert(Spartane.Core.Domain.Tipo_de_Inmueble.Tipo_de_Inmueble entity, Spartane.Core.Domain.User.GlobalData Tipo_de_InmuebleInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            short rta = Convert.ToInt16("0");
            return rta;
        }

        public short Update(Spartane.Core.Domain.Tipo_de_Inmueble.Tipo_de_Inmueble entity, Spartane.Core.Domain.User.GlobalData Tipo_de_InmuebleInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            short rta = Convert.ToInt16("0");
            return rta;
        }
        #endregion
    }
}

