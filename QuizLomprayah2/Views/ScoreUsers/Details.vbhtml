@ModelType QuizLomprayah2.ScoreUser
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

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
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.score_id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
