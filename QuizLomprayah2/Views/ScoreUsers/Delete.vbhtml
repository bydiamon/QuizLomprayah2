@ModelType QuizLomprayah2.ScoreUser
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>ScoreUser</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Score)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Score)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Status)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Status)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Round)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Round)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Scor_Date_Exam)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Scor_Date_Exam)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.book.subject_code)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.book.subject_code)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.EmployeeInformation.employee_ID)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.EmployeeInformation.employee_ID)
        </dd>

    </dl>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
