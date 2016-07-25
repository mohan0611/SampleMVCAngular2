angular.module('QuizApp', ['smart-table'])
    .controller('QuizCtrl', function ($scope, $http, $window) {
        $scope.title = "loading question...";
        //$scope.quizquestion = [];
        $scope.lblLoadQuestionbtn = "Load Question";

        
        $scope.nextQuestion = function () {
            $scope.lblLoadQuestionbtn = "loading question...";
            $scope.quizquestion = [];

            $http.get("/api/trivia").success(function (data, status, headers, config) {
                //debugger;
                $scope.rowCollection = data;
                $scope.itemsByPage = 5;
                //$scope.title = data.title;
                //$scope.answered = false;
                //$scope.working = false;
                $scope.lblLoadQuestionbtn = "Question loaded";
            }).error(function (data, status, headers, config) {
                $scope.title = "Oops... something went wrong";
                //$scope.working = false;
            });
        };


        //remove to the real data holder
        $scope.removeItem = function removeItem(row) {
            if ($window.confirm("Please confirm?")) {
                var index = $scope.rowCollection.indexOf(row);
                console.log(row);
                if (index !== -1) {
                    $scope.rowCollection.splice(index, 1);
                }
            }
        }
        
        
    });






    /*
angular.module('QuizApp', ['smart-table'])
    .controller('QuizCtrl', ['$scope', function (scope) {
    var
        nameList = ['Pierre', 'Pol', 'Jacques', 'Robert', 'Elisa'],
        familyName = ['Dupont', 'Germain', 'Delcourt', 'bjip', 'Menez'];

    function createRandomItem() {
        var
            firstName = nameList[Math.floor(Math.random() * 4)],
            lastName = familyName[Math.floor(Math.random() * 4)];

        return {
            firstName: firstName,
            lastName: lastName,
        };
    }

    scope.itemsByPage = 5;

    scope.rowCollection = [];
    for (var j = 0; j < 20; j++) {
        scope.rowCollection.push(createRandomItem());
    }
}]);  

*/