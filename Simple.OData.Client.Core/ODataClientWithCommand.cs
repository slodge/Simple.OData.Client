﻿using System;
using System.Collections.Generic;

namespace Simple.OData.Client
{
    class ODataClientWithCommand : IClientWithCommand
    {
        private readonly ODataClient _client;
        private readonly ISchema _schema;
        private readonly ODataCommand _command;

        public ODataClientWithCommand(ODataClient client, ISchema schema, ODataCommand parent = null)
        {
            _client = client;
            _schema = schema;
            _command = new ODataCommand(this, parent);
        }

        public ISchema Schema
        {
            get { return _schema; }
        }

        public string CommandText
        {
            get { return _command.ToString(); }
        }

        public ODataClientWithCommand Link(ODataCommand command, string linkName)
        {
            var linkedClient = new ODataClientWithCommand(_client, _schema, command);
            linkedClient._command.Link(linkName);
            return linkedClient;
        }

        public IEnumerable<IDictionary<string, object>> FindEntries()
        {
            return _client.FindEntries(_command.ToString());
        }

        public IEnumerable<IDictionary<string, object>> FindEntries(bool scalarResult)
        {
            return _client.FindEntries(_command.ToString(), scalarResult);
        }

        public IEnumerable<IDictionary<string, object>> FindEntries(out int totalCount)
        {
            var result = _client.FindEntries(_command.WithInlineCount().ToString(), out totalCount);
            return result;
        }

        public IEnumerable<IDictionary<string, object>> FindEntries(bool scalarResult, out int totalCount)
        {
            var result = _client.FindEntries(_command.WithInlineCount().ToString(), scalarResult, out totalCount);
            return result;
        }

        public IDictionary<string, object> FindEntry()
        {
            return _client.FindEntry(_command.ToString());
        }

        public object FindScalar()
        {
            return _client.FindScalar(_command.ToString());
        }

        public IDictionary<string, object> InsertEntry(bool resultRequired = true)
        {
            return _client.InsertEntry(_command.CollectionName, _command.EntryData, resultRequired);
        }

        public int UpdateEntry()
        {
            if (_command.HasFilter)
                return UpdateEntries();
            else
                return _client.UpdateEntry(_command.CollectionName, _command.KeyValues, _command.EntryData);
        }

        public int UpdateEntries()
        {
            return _client.UpdateEntries(_command.CollectionName, _command.ToString(), _command.EntryData);
        }

        public int DeleteEntry()
        {
            if (_command.HasFilter)
                return DeleteEntries();
            else
                return _client.DeleteEntry(_command.CollectionName, _command.KeyValues);
        }

        public int DeleteEntries()
        {
            return _client.DeleteEntries(_command.CollectionName, _command.ToString());
        }

        public void LinkEntry(string linkName, IDictionary<string, object> linkedEntryKey)
        {
            _client.LinkEntry(_command.CollectionName, _command.KeyValues, linkName, linkedEntryKey);
        }

        public void UnlinkEntry(string linkName)
        {
            _client.UnlinkEntry(_command.CollectionName, _command.KeyValues, linkName);
        }

        public IEnumerable<IEnumerable<IEnumerable<KeyValuePair<string, object>>>> ExecuteFunction(string functionName, IDictionary<string, object> parameters)
        {
            return _client.ExecuteFunction(_command.ToString(), parameters);
        }

        public IClientWithCommand For(string collectionName)
        {
            return _command.For(collectionName);
        }

        public IClientWithCommand As(string derivedCollectionName)
        {
            return _command.As(derivedCollectionName);
        }

        public IClientWithCommand Key(params object[] key)
        {
            return _command.Key(key);
        }

        public IClientWithCommand Key(IEnumerable<object> key)
        {
            return _command.Key(key);
        }

        public IClientWithCommand Key(IDictionary<string, object> key)
        {
            return _command.Key(key);
        }

        public IClientWithCommand Filter(string filter)
        {
            return _command.Filter(filter);
        }

        public IClientWithCommand Filter(FilterExpression expression)
        {
            return _command.Filter(expression);
        }

        public IClientWithCommand Skip(int count)
        {
            return _command.Skip(count);
        }

        public IClientWithCommand Top(int count)
        {
            return _command.Top(count);
        }

        public IClientWithCommand Expand(IEnumerable<string> associations)
        {
            return _command.Expand(associations);
        }

        public IClientWithCommand Expand(params string[] associations)
        {
            return _command.Expand(associations);
        }

        public IClientWithCommand Select(IEnumerable<string> columns)
        {
            return _command.Select(columns);
        }

        public IClientWithCommand Select(params string[] columns)
        {
            return _command.Select(columns);
        }

        public IClientWithCommand OrderBy(IEnumerable<KeyValuePair<string,bool>> columns)
        {
            return _command.OrderBy(columns);
        }

        public IClientWithCommand OrderBy(params string[] columns)
        {
            return _command.OrderBy(columns);
        }

        public IClientWithCommand OrderByDescending(params string[] columns)
        {
            return _command.OrderByDescending(columns);
        }

        public IClientWithCommand Count()
        {
            return _command.Count();
        }

        public IClientWithCommand Set(object value)
        {
            return _command.Set(value);
        }

        public IClientWithCommand Set(IDictionary<string, object> value)
        {
            return _command.Set(value);
        }

        public IClientWithCommand Function(string functionName)
        {
            return _command.Function(functionName);
        }

        public IClientWithCommand Parameters(IDictionary<string, object> parameters)
        {
            return _command.Parameters(parameters);
        }

        public IClientWithCommand NavigateTo(string linkName)
        {
            return _command.NavigateTo(linkName);
        }

        public bool FilterIsKey
        {
            get { return _command.FilterIsKey; }
        }

        public IDictionary<string, object> FilterAsKey
        {
            get { return _command.FilterAsKey; }
        }

        public IDictionary<string, object> NewValues
        {
            get { return _command.EntryData; }
        }
    }
}
