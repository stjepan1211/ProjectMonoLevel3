vehicleApp.controller('vehicleModelController', function ($scope, $http) {
    $http.get('/GetAllVml')
    .success(function (response) {
        $scope.vehicleModels = response;
    })
    .error(function () {
        return "error";
    });
});