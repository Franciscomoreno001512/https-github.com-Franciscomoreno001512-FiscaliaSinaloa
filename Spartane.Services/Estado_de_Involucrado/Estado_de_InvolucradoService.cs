using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Estado_de_Involucrado;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Estado_de_Involucrado
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Estado_de_InvolucradoService : IEstado_de_InvolucradoService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Estado_de_Involucrado.Estado_de_Involucrado> _Estado_de_InvolucradoRepository;
        #endregion

        #region Ctor
        public Estado_de_InvolucradoService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Estado_de_Involucrado.Estado_de_Involucrado> Estado_de_InvolucradoRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Estado_de_InvolucradoRepository = Estado_de_InvolucradoRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Estado_de_Involucrado.Estado_de_Involucrado> SelAll(bool ConRelaciones)
        {
            return this._Estado_de_InvolucradoRepository.Table.ToList();
        }

        public IList<Core.Domain.Estado_de_Involucrado.Estado_de_Involucrado> SelAllComplete(bool ConRelaciones)
        {
            return this._Estado_de_InvolucradoRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Estado_de_Involucrado.Estado_de_Involucrado> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Estado_de_InvolucradoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Estado_de_Involucrado.Estado_de_Involucrado> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Estado_de_InvolucradoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Estado_de_Involucrado.Estado_de_Involucrado> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Estado_de_InvolucradoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Estado_de_Involucrado.Estado_de_InvolucradoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Estado_de_InvolucradoPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Estado_de_Involucrado.Estado_de_Involucrado> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Estado_de_InvolucradoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Estado_de_Involucrado.Estado_de_Involucrado GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Estado_de_Involucrado.Estado_de_Involucrado result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Estado_de_InvolucradoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Estado_de_Involucrado.Estado_de_Involucrado entity, Spartane.Core.Domain.User.GlobalData Estado_de_InvolucradoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Estado_de_Involucrado.Estado_de_Involucrado entity, Spartane.Core.Domain.User.GlobalData Estado_de_InvolucradoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

