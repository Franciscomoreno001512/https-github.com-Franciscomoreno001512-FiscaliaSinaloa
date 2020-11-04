using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Lugares_Frecuentes_Involucrado;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Lugares_Frecuentes_Involucrado
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Lugares_Frecuentes_InvolucradoService : ILugares_Frecuentes_InvolucradoService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Lugares_Frecuentes_Involucrado.Lugares_Frecuentes_Involucrado> _Lugares_Frecuentes_InvolucradoRepository;
        #endregion

        #region Ctor
        public Lugares_Frecuentes_InvolucradoService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Lugares_Frecuentes_Involucrado.Lugares_Frecuentes_Involucrado> Lugares_Frecuentes_InvolucradoRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Lugares_Frecuentes_InvolucradoRepository = Lugares_Frecuentes_InvolucradoRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Lugares_Frecuentes_Involucrado.Lugares_Frecuentes_Involucrado> SelAll(bool ConRelaciones)
        {
            return this._Lugares_Frecuentes_InvolucradoRepository.Table.ToList();
        }

        public IList<Core.Domain.Lugares_Frecuentes_Involucrado.Lugares_Frecuentes_Involucrado> SelAllComplete(bool ConRelaciones)
        {
            return this._Lugares_Frecuentes_InvolucradoRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Lugares_Frecuentes_Involucrado.Lugares_Frecuentes_Involucrado> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Lugares_Frecuentes_InvolucradoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Lugares_Frecuentes_Involucrado.Lugares_Frecuentes_Involucrado> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Lugares_Frecuentes_InvolucradoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Lugares_Frecuentes_Involucrado.Lugares_Frecuentes_Involucrado> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Lugares_Frecuentes_InvolucradoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Lugares_Frecuentes_Involucrado.Lugares_Frecuentes_InvolucradoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Lugares_Frecuentes_InvolucradoPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Lugares_Frecuentes_Involucrado.Lugares_Frecuentes_Involucrado> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Lugares_Frecuentes_InvolucradoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Lugares_Frecuentes_Involucrado.Lugares_Frecuentes_Involucrado GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Lugares_Frecuentes_Involucrado.Lugares_Frecuentes_Involucrado result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Lugares_Frecuentes_InvolucradoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Lugares_Frecuentes_Involucrado.Lugares_Frecuentes_Involucrado entity, Spartane.Core.Domain.User.GlobalData Lugares_Frecuentes_InvolucradoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Lugares_Frecuentes_Involucrado.Lugares_Frecuentes_Involucrado entity, Spartane.Core.Domain.User.GlobalData Lugares_Frecuentes_InvolucradoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

