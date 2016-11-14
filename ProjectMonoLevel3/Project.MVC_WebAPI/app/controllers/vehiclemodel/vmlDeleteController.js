angular.module('vehicleApp').controller('vmlDeleteController', ['$scope', '$http', '$stateParams', '$window', vmlDeleteController]);

function vmlDeleteController($scope, $http, $stateParams, $window) {

    $scope.deleteData = {
        VehicleModelId: undefined,
        VehicleMakeId: undefined,
        Name: undefined,
        Abrv: undefined
    };

    var id = $stateParams.VmlId;
    $scope.deleteInit = function () {
        $http.get('/api/VehicleModel/GetVml?id=' + id)
            .success(function (data) {
                $scope.deleteData = data;
            })
            .error(function (data) {
                $window.alert("Error " + data.message);
            })
    }

    $scope.deleteVml = function () {
        if ($window.confirm('Jeste li sigurni da zeli obrisati model?')) {
            $http.delete('/api/VehicleModel/DeleteVml?id=' + id).success(function (data) {
                $scope.response = data;
            })
            .error(function (data) {
            })
        }
    }
}