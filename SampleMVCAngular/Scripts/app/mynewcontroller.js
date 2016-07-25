angular.module('QuizApp')
    .controller('QuizCtrl', function ($scope, $http) {
        $scope.answered = false;
        $scope.title = "loading question...";
        $scope.quizquestion = [];
        $scope.correctAnswer = false;
        $scope.working = false;
        $scope.lblLoadQuestionbtn = "Load Question";

        $scope.answer = function () {
            return $scope.correctAnswer ? 'correct' : 'incorrect';
        };

        $scope.nextQuestion = function () {
            $scope.working = true;
            $scope.answered = false;
            $scope.lblLoadQuestionbtn = "loading question...";
            $scope.quizquestion = [];

            $http.get("/api/trivia").success(function (data, status, headers, config) {
                //debugger;
                $scope.quizquestion = data;
                //$scope.title = data.title;
                //$scope.answered = false;
                //$scope.working = false;
                $scope.lblLoadQuestionbtn = "Question loaded";
            }).error(function (data, status, headers, config) {
                $scope.title = "Oops... something went wrong";
                //$scope.working = false;
            });
        };


        
    });