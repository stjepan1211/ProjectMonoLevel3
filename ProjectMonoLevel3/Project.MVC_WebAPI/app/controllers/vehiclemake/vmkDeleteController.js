angular.module('vehicleApp').controller('vmkDeleteController', ['$scope', '$http', '$stateParams', '$window', vmkDeleteController]);

function vmkDeleteController($scope, $http, $stateParams, $window) {

    var id = $stateParams.VmkId;
    $scope.deleteInit = function () {
        $http.get('/api/VehicleMake/GetVmk?id=' + id)
            .success(function (data) {
                $scope.deleteData = data;
            })
            .error(function (data) {
                $window.alert("Error " + data.message);
            })
    }
    
    $scope.deleteVmk = function () {
        if ($window.confirm('Jeste li sigurni da zeli obrisati makera?')) {
            $http.delete('/api/VehicleMake/DeleteVmk?id=' + id).success(function (data) {
                $scope.response = data;
            })
            .error(function (data) {
            })
        }
    }
}