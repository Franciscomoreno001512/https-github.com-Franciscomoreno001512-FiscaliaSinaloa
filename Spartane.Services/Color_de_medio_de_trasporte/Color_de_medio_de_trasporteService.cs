using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Color_de_medio_de_trasporte;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Color_de_medio_de_trasporte
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Color_de_medio_de_trasporteService : IColor_de_medio_de_trasporteService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Color_de_medio_de_trasporte.Color_de_medio_de_trasporte> _Color_de_medio_de_trasporteRepository;
        #endregion

        #region Ctor
        public Color_de_medio_de_trasporteService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Color_de_medio_de_trasporte.Color_de_medio_de_trasporte> Color_de_medio_de_trasporteRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Color_de_medio_de_trasporteRepository = Color_de_medio_de_trasporteRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Color_de_medio_de_trasporte.Color_de_medio_de_trasporte> SelAll(bool ConRelaciones)
        {
            return this._Color_de_medio_de_trasporteRepository.Table.ToList();
        }

        public IList<Core.Domain.Color_de_medio_de_trasporte.Color_de_medio_de_trasporte> SelAllComplete(bool ConRelaciones)
        {
            return this._Color_de_medio_de_trasporteRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Color_de_medio_de_trasporte.Color_de_medio_de_trasporte> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Color_de_medio_de_trasporteRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Color_de_medio_de_trasporte.Color_de_medio_de_trasporte> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Color_de_medio_de_trasporteRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Color_de_medio_de_trasporte.Color_de_medio_de_trasporte> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Color_de_medio_de_trasporteRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Color_de_medio_de_trasporte.Color_de_medio_de_trasportePagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Color_de_medio_de_trasportePagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Color_de_medio_de_trasporte.Color_de_medio_de_trasporte> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Color_de_medio_de_trasporteRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Color_de_medio_de_trasporte.Color_de_medio_de_trasporte GetByKey(short Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Color_de_medio_de_trasporte.Color_de_medio_de_trasporte result=null;
            return result;
        }

        public bool Delete(short Key, Spartane.Core.Domain.User.GlobalData Color_de_medio_de_trasporteInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public short Insert(Spartane.Core.Domain.Color_de_medio_de_trasporte.Color_de_medio_de_trasporte entity, Spartane.Core.Domain.User.GlobalData Color_de_medio_de_trasporteInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            short rta = Convert.ToInt16("0");
            return rta;
        }

        public short Update(Spartane.Core.Domain.Color_de_medio_de_trasporte.Color_de_medio_de_trasporte entity, Spartane.Core.Domain.User.GlobalData Color_de_medio_de_trasporteInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            short rta = Convert.ToInt16("0");
            return rta;
        }
        #endregion
    }
}

