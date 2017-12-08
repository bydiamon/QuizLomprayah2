@ModelType QuizLomprayah2.Position_Exam
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>Position_Exam</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Position_exam1)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Position_exam1)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.book.subject_code)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.book.subject_code)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.exam_id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
