using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Unidad_de_medida_de_tipo_de_droga;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Unidad_de_medida_de_tipo_de_droga
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Unidad_de_medida_de_tipo_de_drogaService : IUnidad_de_medida_de_tipo_de_drogaService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Unidad_de_medida_de_tipo_de_droga.Unidad_de_medida_de_tipo_de_droga> _Unidad_de_medida_de_tipo_de_drogaRepository;
        #endregion

        #region Ctor
        public Unidad_de_medida_de_tipo_de_drogaService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Unidad_de_medida_de_tipo_de_droga.Unidad_de_medida_de_tipo_de_droga> Unidad_de_medida_de_tipo_de_drogaRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Unidad_de_medida_de_tipo_de_drogaRepository = Unidad_de_medida_de_tipo_de_drogaRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Unidad_de_medida_de_tipo_de_droga.Unidad_de_medida_de_tipo_de_droga> SelAll(bool ConRelaciones)
        {
            return this._Unidad_de_medida_de_tipo_de_drogaRepository.Table.ToList();
        }

        public IList<Core.Domain.Unidad_de_medida_de_tipo_de_droga.Unidad_de_medida_de_tipo_de_droga> SelAllComplete(bool ConRelaciones)
        {
            return this._Unidad_de_medida_de_tipo_de_drogaRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Unidad_de_medida_de_tipo_de_droga.Unidad_de_medida_de_tipo_de_droga> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Unidad_de_medida_de_tipo_de_drogaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Unidad_de_medida_de_tipo_de_droga.Unidad_de_medida_de_tipo_de_droga> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Unidad_de_medida_de_tipo_de_drogaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Unidad_de_medida_de_tipo_de_droga.Unidad_de_medida_de_tipo_de_droga> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Unidad_de_medida_de_tipo_de_drogaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Unidad_de_medida_de_tipo_de_droga.Unidad_de_medida_de_tipo_de_drogaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Unidad_de_medida_de_tipo_de_drogaPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Unidad_de_medida_de_tipo_de_droga.Unidad_de_medida_de_tipo_de_droga> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Unidad_de_medida_de_tipo_de_drogaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Unidad_de_medida_de_tipo_de_droga.Unidad_de_medida_de_tipo_de_droga GetByKey(short Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Unidad_de_medida_de_tipo_de_droga.Unidad_de_medida_de_tipo_de_droga result=null;
            return result;
        }

        public bool Delete(short Key, Spartane.Core.Domain.User.GlobalData Unidad_de_medida_de_tipo_de_drogaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public short Insert(Spartane.Core.Domain.Unidad_de_medida_de_tipo_de_droga.Unidad_de_medida_de_tipo_de_droga entity, Spartane.Core.Domain.User.GlobalData Unidad_de_medida_de_tipo_de_drogaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            short rta = Convert.ToInt16("0");
            return rta;
        }

        public short Update(Spartane.Core.Domain.Unidad_de_medida_de_tipo_de_droga.Unidad_de_medida_de_tipo_de_droga entity, Spartane.Core.Domain.User.GlobalData Unidad_de_medida_de_tipo_de_drogaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            short rta = Convert.ToInt16("0");
            return rta;
        }
        #endregion
    }
}

