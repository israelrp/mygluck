app.factory('crudGridDataFactory', ['$http', '$resource', function ($http, $resource) {
    return function (type) {
        return $resource('http://localhost:5271/api/' + type + '/:id', { id: '@id' }, { 'update': { method: 'PUT' } }, { 'query': { method: 'GET', isArray: false } });
    };
}]);