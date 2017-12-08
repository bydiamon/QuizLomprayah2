@ModelType QuizLomprayah2.EssayTest
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>EssayTest</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.EssayTest_Question)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.EssayTest_Question)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.EssayTest_Answer_User)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.EssayTest_Answer_User)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.EssayTest_Answer)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.EssayTest_Answer)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.EssayTest_ExamDate)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.EssayTest_ExamDate)
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
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.EssayTest_id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
