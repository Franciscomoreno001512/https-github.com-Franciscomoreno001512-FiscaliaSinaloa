using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Detalle_de_Citatorio_Audiencias;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Detalle_de_Citatorio_Audiencias
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Detalle_de_Citatorio_AudienciasService : IDetalle_de_Citatorio_AudienciasService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Detalle_de_Citatorio_Audiencias.Detalle_de_Citatorio_Audiencias> _Detalle_de_Citatorio_AudienciasRepository;
        #endregion

        #region Ctor
        public Detalle_de_Citatorio_AudienciasService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Detalle_de_Citatorio_Audiencias.Detalle_de_Citatorio_Audiencias> Detalle_de_Citatorio_AudienciasRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Detalle_de_Citatorio_AudienciasRepository = Detalle_de_Citatorio_AudienciasRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Detalle_de_Citatorio_Audiencias.Detalle_de_Citatorio_Audiencias> SelAll(bool ConRelaciones)
        {
            return this._Detalle_de_Citatorio_AudienciasRepository.Table.ToList();
        }

        public IList<Core.Domain.Detalle_de_Citatorio_Audiencias.Detalle_de_Citatorio_Audiencias> SelAllComplete(bool ConRelaciones)
        {
            return this._Detalle_de_Citatorio_AudienciasRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Detalle_de_Citatorio_Audiencias.Detalle_de_Citatorio_Audiencias> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_de_Citatorio_AudienciasRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_de_Citatorio_Audiencias.Detalle_de_Citatorio_Audiencias> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Detalle_de_Citatorio_AudienciasRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_de_Citatorio_Audiencias.Detalle_de_Citatorio_Audiencias> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_de_Citatorio_AudienciasRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_de_Citatorio_Audiencias.Detalle_de_Citatorio_AudienciasPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Detalle_de_Citatorio_AudienciasPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Detalle_de_Citatorio_Audiencias.Detalle_de_Citatorio_Audiencias> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Detalle_de_Citatorio_AudienciasRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_de_Citatorio_Audiencias.Detalle_de_Citatorio_Audiencias GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Detalle_de_Citatorio_Audiencias.Detalle_de_Citatorio_Audiencias result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Detalle_de_Citatorio_AudienciasInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Detalle_de_Citatorio_Audiencias.Detalle_de_Citatorio_Audiencias entity, Spartane.Core.Domain.User.GlobalData Detalle_de_Citatorio_AudienciasInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Detalle_de_Citatorio_Audiencias.Detalle_de_Citatorio_Audiencias entity, Spartane.Core.Domain.User.GlobalData Detalle_de_Citatorio_AudienciasInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

